steal('funcunit').then(function(){

module("Projects.Router", { 
	setup: function(){
		S.open("//projects/router/router.html");
	}
});

test("Text Test", function(){
	equals(S("h1").text(), "Projects.Router Demo","demo text");
});


});