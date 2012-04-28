steal('jquery/model', function(){

/**
 * @class Projects.Models.Project
 * @parent index
 * @inherits jQuery.Model
 * Wraps backend project services.  
 */
$.Model('Projects.Models.Project',
/* @Static */
{
    findAll: "GET http://api.projects.local/v1/projects",
    findOne: "GET http://api.projects.local/v1/projects/{id}",
  	create : "POST /api/v1/projects",
 	update : "PUT /api/v1/projects/{id}",
  	destroy : "DELETE /api/v1/projects/{id}"
},
/* @Prototype */
{});

})