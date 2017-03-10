
	 $(document).ready(function() {
		$.ajax({
		    url:'http://localhost:3258/RService.svc/rest/Employees',
			method:'GET'
			
		}).done(function(res){
			
			   var obj=res;
			   for(var i=0;i<obj.length;i++){
				
					$('.d2').append('<div class="data"><p>'+obj[i].Emp_ID+'</p><p>'+obj[i].Emp_Name+'</p><p>'+obj[i].DP_ID+'</p></div>');
			   }
		

		})

	
		

		})
		
		
		//$.ajax({
		//	url:'http://localhost:9999/file_lab4.svc/rest/Book',
		//	method:'POST',
		//	dataType:"json",
		//	contentType:"application/json",
		//	data:JSON.stringify(obj1)
			
		//}).done(function(res){
		//console.log(res)}).fail(function(error)function myFunction() {
		//	var x=document.getElementById("Emp_ID").value;
		//	var y=document.getElementById("Emp_Name").value;
		//    var z= document.getElementById("DP_ID").value;
		//	var obj1= {Emp_ID:x,
		//			   Emp_Name:y,
		//			 DP_ID:z})}