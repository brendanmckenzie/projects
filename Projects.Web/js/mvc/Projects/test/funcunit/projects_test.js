steal("funcunit", function(){
	module("projects test", { 
		setup: function(){
			S.open("//Projects/projects.html");
		}
	});
	
	test("Copy Test", function(){
		equals(S("h1").text(), "Welcome to JavaScriptMVC 3.2!","welcome text");
	});
})