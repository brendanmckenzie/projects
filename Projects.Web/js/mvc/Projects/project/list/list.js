steal( 'jquery/controller',
	   'jquery/view/ejs',
	   'jquery/controller/view',
	   'projects/models' )
.then( './views/init.ejs', 
       './views/project.ejs', 
       function($){

/**
 * @class Projects.Project.List
 * @parent index
 * @inherits jQuery.Controller
 * Lists projects and lets you destroy them.
 */
$.Controller('Projects.Project.List',
/** @Static */
{
	defaults : {}
},
/** @Prototype */
{
	init : function(){
		this.element.html(this.view('init',Projects.Models.Project.findAll()) )
	},
	'.destroy click': function( el ){
		if(confirm("Are you sure you want to destroy?")){
			el.closest('.project').model().destroy();
		}
	},
	"{Projects.Models.Project} destroyed" : function(Project, ev, project) {
		project.elements(this.element).remove();
	},
	"{Projects.Models.Project} created" : function(Project, ev, project){
		this.element.append(this.view('init', [project]))
	},
	"{Projects.Models.Project} updated" : function(Project, ev, project){
		project.elements(this.element)
		      .html(this.view('project', project) );
	}
});

});