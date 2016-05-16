var app = app || {};

(function (diablo) {
    'use strict';

    function HeroesController(model, classModel, itemsModel, viewBag, notifier) {
        this.model = model;
        this.classModel = classModel;
        this.itemsModel = itemsModel;
        this.viewBag = viewBag;
        this.notifier = notifier;
    }

    HeroesController.prototype.getAll = function getAll(container) {
        var _this = this;
        this.model.getAll().then(
            function success(data) {
                _this.viewBag.showHeroes(container, data);
            },
            function error() {

            }).done();
    };

    HeroesController.prototype.listUsersHeroes = function listUsersHeroes(container) {
        var userId = sessionStorage.userId;
        var _this = this;
        this.model.listUsersHeroes(userId).then(
            function success(data) {
                _this.viewBag.showUsersHeroes(container, data);
            },
            function error() {
                _this.notifier.notifyError('Failed to load heroes');
            }).done();
    };

    HeroesController.prototype.loadHeroPage = function loadHeroPage(heroId, container) {
        var _this = this;
        this.model.getHero(heroId).then(
            function success(data) {
                data.attackPoints = data.class['attack-points'];
                data.defensePoints = data.class['defense-points'];
                data.lifePoints = data.class['life-points'];
                if (data.items) {
                    data.items.forEach(function (item) {
                        data.attackPoints += item['attack-points'];
                        data.defensePoints += item['defense-points'];
                        data.lifePoints += item['life-points'];
                    });
                }

                _this.viewBag.showHeroPage(container, data);
            }, function error(data) {
                console.error(data);
            }).done();
    };

    HeroesController.prototype.loadAddHero = function loadAddHero(container) {
        var _this = this;
        this.classModel.getAll().then(function success(data) {
            _this.viewBag.showAddHero(container, data);
        }).done();
    };

    HeroesController.prototype.addHero = function addHero(data) {
        var hero = {
            name: data.name,
            class: {
                _type: "KinveyRef",
                _id: data.classId,
                _collection: "hero-classes"
            }
        };

        var _this = this;
        this.model.addHero(hero).then(
            function success() {
                _this.notifier.notifySuccess('Successfully added new hero');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/heroes/list/' });
                });
            },
            function error(data) {
                console.error(data);
                _this.notifier.notifyError('Invalid hero data');
            }).done();
    };

    HeroesController.prototype.loadStore = function loadStore(heroId, container) {
        var _this = this;
        this.itemsModel.getStoreItems(heroId).then(
            function success(data) {
                data.heroId = heroId;
                _this.viewBag.showStore(container, data);
            }, function error(data) {
                console.error(data);
            }).done();
    };

    HeroesController.prototype.addItem = function addItem(data) {
        var _this = this;
        var item = {
            _type: "KinveyRef",
            _id: data.itemId,
            _collection: "items"
        };
        var hasItem = false;
        this.model.getHero(data.heroId).then(function (hero) {
            if (hero.items) {
                hero.items.forEach(function (item) {
                    if (item.type.name === data.type) {
                        hasItem = true;
                    }
                });
            }

            if (!hasItem) {
                if (!hero.items) {
                    hero.items = [];
                }
                hero.items.push(item);
                _this.editHero(data.heroId, hero);
            } else {
                _this.notifier.confirm('You already have ' + data.type + '. Do you want to throw it and buy this item instead?')
                    .then(function (answer) {
                        if (answer) {
                            hero.items = hero.items.filter(function (item) {
                                return item.type.name !== data.type;
                            });

                            hero.items.push(item);
                            _this.editHero(data.heroId, hero);
                        }
                    });
            }

        }).done();
    };

    HeroesController.prototype.editHero = function editHero(heroId, editedHero) {
        var _this = this;
        this.model.editHero(heroId, editedHero).then(
            function success() {
                _this.notifier.notifySuccess('Successfully added item');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/heroes/' + heroId });
                });
            },
            function error(data) {
                console.error(data);
                _this.notifier.notifyError('');
            });
    };

    diablo.heroesController = {
        load: function (model, classModel, itemsModel, viewBag, notifier) {
            return new HeroesController(model, classModel, itemsModel, viewBag, notifier);
        }
    };

} (app));