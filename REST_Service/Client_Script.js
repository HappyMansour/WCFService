$('document').ready(function () {
    //view emp
    $.ajax({
        url: 'http://localhost:3258/RService.svc/rest/Employees',
        method: 'Get',

    }).done(function (res) {
        $('.ve').click(function () {
            var data = res;
            console.log(data);
            for (var i = 0, length = data.length; i < length; i++) {
                $('.main_emp').append("<div><p>ID:" + data[i].ID + "</p><p> Name:" + data[i].Name + "</p><p>Department ID:" + data[i].Dept_ID + "</p></div></br>");
            }

        })
    })

    //view dep
    $.ajax({
        url: 'http://localhost:3258/RService.svc/rest/Departments',
        method: 'Get',

    }).done(function (res) {
        $('.vd').click(function () {
            var data = res;
            console.log(data);
            for (var i = 0, length = data.length; i < length; i++) {
                $('.main_dep').append("<div><p>ID:" + data[i].DP_ID + "</p><p> Name:" + data[i].DP_Name + "</p></div></br>");
            }

        })
    })

    //insert emp
    $('.ie').click(function () {
        var obj = {
            Emp_ID: $('.emp_id').val(),
            Emp_Name: $('.emp_name').val(),
            DP_ID: $('.Dp_id').val(),
        };
        console.log(obj);

        $.ajax({
            url: 'http://localhost:3258/RService.svc/rest/Employee',
            dataType: 'json',
            contentType: 'application/json',
            method: 'POST',
            data: JSON.stringify({ Emp_ID:7,Emp_Name:'kamal',DP_ID:3})
        }).done(function () { console.log('true') }).fail(function () {
            console.log('false')
        })

    })

    //insert dep
    $('.id').click(function () {

        var obj = {
            Emp_ID: $('.dep_id').val(),
            Emp_Name: $('.dep_name').val(),
        };

        $.ajax({
            url: 'http://localhost:3258/RService.svc/rest/Department',
            dataType: 'jsonp',
            contentType: 'application/json',
            method: 'POST',
            data: JSON.stringify(obj)
        }).done(function () { console.log('true') }).fail(function () { console.log('false') })




    })


  


})

