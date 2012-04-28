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
                this.element.html(this.view('init.mustache', Projects.Models.Project.findAll()))
            }
        })
    });