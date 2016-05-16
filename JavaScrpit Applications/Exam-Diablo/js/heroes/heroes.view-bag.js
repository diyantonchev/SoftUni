var app = app || {};

(function (diablo) {
    'use strict';

    function showUsersHeroes(container, data) {
        if (data.length) {
            $.get('templates/heroes.html', function (template) {
                data.heroes = data;
                var rendered = Mustache.render(template, data);
                $(container).html(rendered);
            });
        } else {
            $.get('templates/no-heroes.html', function (template) {
                $(container).html(template);
            });
        }
    }

    function showAddHero(container, data) {
        $.get('templates/add-hero.html', function (template) {
            data.classes = data;
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
            $('#addHero').on('click', function () {
                var name = $('#name').val();
                var classId = "";
                var selected = $("input[type='radio']:checked");
                if (selected.length > 0) {
                    classId = selected.val();
                }

                var data = { name: name, classId: classId };
                Sammy(function () {
                    this.trigger('addHero', data);
                });
            });
        });
    }

    function showHeroPage(container, data) {
        $.get('templates/hero.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
        });
    }

    function showStore(container, data) {
        $.get('templates/store.html', function (template) {
            data.items = data;
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
            $('.buy').on('click', function () {
                var heroId = data.heroId;
                var itemId = $(this).attr('data-id');
                var type = $(this).attr('data-type');
                Sammy(function () {
                    this.trigger('addItem', { heroId: heroId, itemId: itemId, type: type });
                });
            });
        });
    }

    diablo.heroesViewBag = {
        showUsersHeroes: showUsersHeroes,
        showAddHero: showAddHero,
        showHeroPage: showHeroPage,
        showStore: showStore
    };

} (app));