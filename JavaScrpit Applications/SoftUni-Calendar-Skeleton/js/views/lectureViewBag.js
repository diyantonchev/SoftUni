var app = app || {};

app.lectureViewBag = (function () {
    "use strict";

    function showAddLecturePage(selector) {
        $.get('templates/add-lecture.html', function (templ) {
            $(selector).html(templ);
            $('#addLecture').on('click', function () {
                var title = $('#title').val(),
                    start = $('#start').val(),
                    end = $('#end').val();

                Sammy(function () {
                    this.trigger('addLecture', {title: title, start: start, end: end});
                });
            });
        });
    }

    function showCalendar(selector, data) {
        // console.log(data);
        $.get('templates/calendar.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(selector).html(templ);
        }).then(function () {
            $('#calendar').fullCalendar({
                theme: false,
                header: {
                    left: 'prev,next today addEvent',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                defaultDate: '2016-01-12',
                selectable: false,
                editable: false,
                eventLimit: true,
                events: data,
                customButtons: {
                    addEvent: {
                        text: 'Add Event',
                        click: function () {
                            showAddLecturePage(selector);
                        }
                    }
                },
                eventClick: function (calEvent, jsEvent, view) {
                    $.get('templates/modal.html', function (templ) {
                        var rendered = Mustache.render(templ, calEvent);
                        $('#modal-body').html(rendered);
                        $('#editLecture').on('click', function () {
                            showEditLecture(selector);
                        });
                        $('#deleteLecture').on('click', function () {
                            showDeleteLecture(selector, data);
                        })
                    });
                    $('#events-modal').modal();
                }
            });

        }).done();
    }

    function showMyLectures(selector, data) {
        $.get('templates/calendar.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(selector).html(templ);
        }).then(function () {
            $('#calendar').fullCalendar({
                theme: false,
                header: {
                    left: 'prev,next today addEvent',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                defaultDate: '2016-01-12',
                selectable: false,
                editable: false,
                eventLimit: true,
                events: data,
                customButtons: {
                    addEvent: {
                        text: 'Add Event',
                        click: function () {
                            showAddLecturePage(selector);
                        }
                    }
                },
                eventClick: function (calEvent, jsEvent, view) {
                    $.get('templates/modal.html', function (templ) {
                        var rendered = Mustache.render(templ, calEvent);
                        $('#modal-body').html(rendered);
                        $('#editLecture').on('click', function () {
                            showEditLecture(selector);
                        });
                        $('#deleteLecture').on('click', function () {
                            showDeleteLecture(selector, data);
                        })
                    });
                    $('#events-modal').modal();
                }
            });

        }).done();
    }

    function showEditLecture(selector) {
        $.get('templates/edit-lecture.html', function (templ) {
            var rendered = Mustache.render(templ);
            $(selector).html(rendered);
            $('#editLecture').on('click', function () {
                var title = $('#title').val(),
                    start = $('#start').val(),
                    end = $('#end').val();

                Sammy(function () {
                    this.trigger('editLecture', {title: title, start: start, end: end});
                });
            });
        })
    }

    function showDeleteLecture(selector, data) {
        $.get('templates/delete-lecture.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(selector).html(rendered);
            $('#deleteLecture').on('click', function () {
                var id = $(this).attr('data-id');

                Sammy(function () {
                    this.trigger('deleteLecture', {_id: id});
                });
            })
        })
    }

    return {
        load: function () {
            return {
                showAddLecturePage: showAddLecturePage,
                showCalendar: showCalendar,
                showMyLectures: showMyLectures,
                showEditLecture: showEditLecture,
                showDeleteLecture: showDeleteLecture
            }
        }
    }
}());