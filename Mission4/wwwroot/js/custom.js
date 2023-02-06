$(".calculate-form").on('submit', function() {
    var assignments = $("#assignments").val()
    var groupproject = $("#groupproject").val()
    var quizzes = $("#quizzes").val()
    var midtermexam = $("#midtermexam").val()
    var finalexam = $("#finalexam").val()
    var intex = $("#intex").val()
    var finalgrade =
        (assignments * .5) +
        (groupproject *.1) +
        (quizzes *.1) +
        (midtermexam * .1) +
        (finalexam * .1) +
        (intex * .1)
    alert("Your final grade is: " + finalgrade + "%")
})
