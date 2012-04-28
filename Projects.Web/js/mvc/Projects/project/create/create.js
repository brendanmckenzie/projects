steal( 'jquery/controller',
       'jquery/view/ejs',
	   'jquery/dom/form_params',
	   'jquery/controller/view',
	   'projects/models' )
	.then('./views/init.ejs', function($){

/**
 * @class Projects.Project.Create
 * @parent index
 * @inherits jQuery.Controller
 * Creates projects
 */
$.Controller('Projects.Project.Create',
/** @Prototype */
{
	init : function(){
		this.element.html(this.view());
	},
	submit : function(el, ev){
		ev.preventDefault();
		this.element.find('[type=submit]').val('Creating...')
		new Projects.Models.Project(el.formParams()).save(this.callback('saved'));
	},
	saved : function(){
		this.element.find('[type=submit]').val('Create');
		this.element[0].reset()
	}
})

});