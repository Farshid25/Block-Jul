$.ajax({
	type: 'GET',
	url: "/api/User/all",
	data: { get_param: 'value' },
	dataType: 'json',
	success: function (data) {

		$.each(data, function (index, user) {
            $("#tablebody").append(
                "test" + 
                "<tr>" +
                    "<td>" + user.id + "</td>" +
                    "<td>" + user.age + "</td>" +
                    "<td>" + user.name + "</td>" +
                "</tr>"
			);
		});
	}	
});
 
$(document).ready(function () {
	$("#register").click(function () {
		var age = $('#age').val();
		var name = $('#name').val();
		alert(age + " " + name);
		$.ajax({
            type: "POST",
            url: "/api/User",
            dataType: 'json',
            data: "Age=" + age + "&Name=" + name,
            success: function (msg) {
                alert("Data Saved: " + msg);
            }
        });
    });
});

