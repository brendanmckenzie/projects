steal(
    'jquery/controller',
	'jquery/controller/view',
    'jquery/view/mustache',
    'projects/models')
.then(
    './views/init.mustache',
    function ($) {
        /**
         * @class Projects.Home
         */
        $.Controller('Projects.Home',
        /** @Static */
        {
            defaults: {}
        },
        /** @Prototype */
        {
            init: function () {
                this.render();
            },
            update: function () {
                this.render();
            },
            render: function () {
                this.element.html(this.view('init.mustache', Projects.Models.Project.findAll()));

            },
            '.project click': function (el, ev) {
                var id = el.attr('data-id');
                location.hash = $.route.url({ id: id });
            }
        })
    });