// map fixtures for this application

steal("jquery/dom/fixture", function(){
	
	$.fixture.make("project", 5, function(i, project){
		var descriptions = ["grill fish", "make ice", "cut onions"]
		return {
			name: "project "+i,
			description: $.fixture.rand( descriptions , 1)[0]
		}
	})
})