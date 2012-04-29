steal(
    'jquery/controller',
    'jquery/view/mustache')
.then(
    './views/init.mustache',
    function ($) {
        /**
         * @class Projects.Project.Open
         */
        $.Controller('Projects.Project.Open',
        /** @Static */
        {
            defaults: {}
        },
        /** @Prototype */
        {
            init: function () {
                alert('hi');
                this.element.html("//projects/project/open/views/init.mustache", {
                    message: "Hello World"
                });
            }
        })
    });