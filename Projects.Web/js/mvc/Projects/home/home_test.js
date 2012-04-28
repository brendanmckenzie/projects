steal('funcunit').then(function(){

module("Projects.Home", { 
	setup: function(){
		S.open("//projects/home/home.html");
	}
});

test("Text Test", function(){
	equals(S("h1").text(), "Projects.Home Demo","demo text");
});


});