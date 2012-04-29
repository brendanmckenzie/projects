var setState = function () { };
steal(
    'jquery/controller/route',
	'projects/home',
	'projects/project/open',
    function ($) {

        /**
         * @class Projects.Router
         */
        $.Controller('Projects.Router',
        /** @Static */
        {
            defaults: {}
        },
        /** @Prototype */
        {
            init: function () {
                $.route("project/:id", { id: '' });
                $.route("home");
            },
            "project/:id route": function (obj) {
                $('[rol="main"]').projects_project_open(obj.id);
            },
            "home route": function (obj) {
                $('[rol="main"]').projects_home();
            }
        })
    });