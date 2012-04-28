steal("funcunit/qunit", "projects/fixtures", "projects/models/project.js", function(){
	module("Model: Projects.Models.Project")
	
	test("findAll", function(){
		expect(4);
		stop();
		Projects.Models.Project.findAll({}, function(projects){
			ok(projects)
	        ok(projects.length)
	        ok(projects[0].name)
	        ok(projects[0].description)
			start();
		});
		
	})
	
	test("create", function(){
		expect(3)
		stop();
		new Projects.Models.Project({name: "dry cleaning", description: "take to street corner"}).save(function(project){
			ok(project);
	        ok(project.id);
	        equals(project.name,"dry cleaning")
	        project.destroy()
			start();
		})
	})
	test("update" , function(){
		expect(2);
		stop();
		new Projects.Models.Project({name: "cook dinner", description: "chicken"}).
	            save(function(project){
	            	equals(project.description,"chicken");
	        		project.update({description: "steak"},function(project){
	        			equals(project.description,"steak");
	        			project.destroy();
						start();
	        		})
	            })
	
	});
	test("destroy", function(){
		expect(1);
		stop();
		new Projects.Models.Project({name: "mow grass", description: "use riding mower"}).
	            destroy(function(project){
	            	ok( true ,"Destroy called" )
					start();
	            })
	})
})