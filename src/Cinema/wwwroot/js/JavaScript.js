function ShowFuncButton(people, hours) {
    $.ajax({
        method: "POST",
        url: "Summ",
        async: false,
        data: {
            peopleJS: people,
            housJS: hours
        },
        success: function (data) {
            console.log(data);
            sum = data.peopleJS * data.hoursJS * 10;
        },
        error: function (data) {
            console.log("aaaaa");
        }
    });
}