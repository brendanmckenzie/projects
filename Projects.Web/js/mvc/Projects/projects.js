steal(
	'./models/models.js',		// steals all your models
	'./fixtures/fixtures.js',	// sets up fixtures for your models
	'projects/home',
	'projects/project/list',
	function () {					// configure your application

	    $('div[role="main"]').projects_home();
	})