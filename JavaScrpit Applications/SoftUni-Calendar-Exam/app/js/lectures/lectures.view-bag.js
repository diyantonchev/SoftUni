var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function showLectures(container, lectures) {
        $.get('templates/calendar.html', function (template) {
            var rendered = Mustache.render(template, lectures);
            $(container).html(rendered);
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
                events: lectures,
                customButtons: {
                    addEvent: {
                        text: 'Add Event',
                        click: function () {
                            Sammy(function () {
                                this.trigger('redirectUrl', { url: '#/calendar/add/' });
                            });
                        }
                    }
                },
                eventClick: function (calEvent, jsEvent, view) {
                    $.get('templates/modal.html', function (templ) {
                        var rendered = Mustache.render(templ, calEvent);
                        $('#modal-body').html(rendered);
                        $('#editLecture').on('click', function () {
                            var url = '#/calendar/edit/' + calEvent._id;
                            Sammy(function () {
                                this.trigger('redirectUrl', { url: url, data: calEvent });
                            });
                        });
                        $('#deleteLecture').on('click', function () {
                            Sammy(function () {
                                this.trigger('redirectUrl', { url: '#/calendar/delete/' + calEvent._id, data: calEvent });
                            });
                        });
                    });
                    $('#events-modal').modal();
                }
            });

        });
    }

    function showAddLectureForm(container) {
        $.get('templates/add-lecture.html', function (template) {
            $(container).html(template);
            $('#addLecture').on('click', function () {
                var title = $('#title').val();
                var start = $('#start').val();
                var end = $('#end').val();
                var lectureData = { title: title, start: start, end: end };
                Sammy(function () {
                    this.trigger('addLecture', lectureData);
                });
            });
        });
    }

    function showEditLectureForm(container, data) {
        $.get('templates/edit-lecture.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
            $('#editLecture').on('click', function () {
                var title = $('#title').val();
                var start = $('#start').val();
                var end = $('#end').val();
                var id = $(this).attr('data-id');
                var lectureData = { title: title, start: start, end: end, _id: id };
                Sammy(function () {
                    this.trigger('editLecture', lectureData);
                });
            });
        });
    }

    function showDeleteLectureForm(container, data) {
        $.get('templates/delete-lecture.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
            $('#deleteLecture').on('click', function () {
                var id = $(this).attr('data-id');
                Sammy(function () {
                    this.trigger('deleteLecture', { _id: id });
                });
            });
        });
    }

    softUniCalendar.lecturesViewBag = {
        showLectures: showLectures,
        showAddLectureForm: showAddLectureForm,
        showEditLectureForm: showEditLectureForm,
        showDeleteLectureForm: showDeleteLectureForm
    };

})(app);