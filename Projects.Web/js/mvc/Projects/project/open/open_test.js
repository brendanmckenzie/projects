steal('funcunit').then(function(){

module("Projects.Project.Open", { 
	setup: function(){
		S.open("//projects/project/open/open.html");
	}
});

test("Text Test", function(){
	equals(S("h1").text(), "Projects.Project.Open Demo","demo text");
});


});