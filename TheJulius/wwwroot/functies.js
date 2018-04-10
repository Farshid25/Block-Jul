$.ajax({
	type: 'GET',
	url: "/api/User/all",
	data: { get_param: 'value' },
	dataType: 'json',
	success: function (data) {

		$.each(data, function (index, user) {
			$("#lijstUsers").append(
				"<p>" +
				"<b>id: </b>" + user.id + "</br>" +
				"<b>bsn: </b>" + user.age + "</br>" +
				"<b>title: </b>" + user.name + "</br>" +
				"</p>"
			);
		});
	}	
});
 
$(document).ready(function () {
	$("#send").click(function () {
		var age = $('#age').val();
		var name = $('#name').val();
		alert(age + " " + name);
		$.ajax({
			type: "POST",
			url: "/api/User",
			data: "/api/User?Age=" + age + "&Name=" + name,
			success: function (msg) {
				alert("Data Saved: " + msg);
			}
		});
	});
});

