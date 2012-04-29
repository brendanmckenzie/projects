steal(
	'projects/home',
    'projects/router',
	function () {					// configure your application
	    $('body').projects_router();
	    $('div[role="main"]').projects_home();
	})