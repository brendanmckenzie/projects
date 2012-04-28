//js Projects/scripts/doc.js

load('steal/rhino/rhino.js');
steal("documentjs").then(function(){
	DocumentJS('Projects/projects.html', {
		markdown : ['projects']
	});
});