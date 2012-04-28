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
	findAll: "/projects.json",
  	findOne : "/projects/{id}.json", 
  	create : "/projects.json",
 	update : "/projects/{id}.json",
  	destroy : "/projects/{id}.json"
},
/* @Prototype */
{});

})