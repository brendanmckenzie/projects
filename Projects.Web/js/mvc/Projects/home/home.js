steal( 'jquery/controller','jquery/view/ejs' )
	.then( './views/init.ejs', function($){

/**
 * @class Projects.Home
 */
$.Controller('Projects.Home',
/** @Static */
{
	defaults : {}
},
/** @Prototype */
{
	init : function(){
		this.element.html("//projects/home/views/init.ejs",{
			message: "Hello World"
		});
	}
})

});