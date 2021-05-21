

$("#checkout-submit").on("click", function (e) {
    e.preventDefault()

    //show error messages if front end has validation errors
    var validationFields = $("span[data-valmsg-for]")
    var foundErrors=false
    for (var i = 0; i < validationFields.length; i++) {
        if (validationFields[i].innerText.length > 0)
        {
            $("#custom-errors")
                .append("<div class='alert alert-danger alert-dismissible fade show' role='alert'>You should check in on some of those fields below.</div >")
            foundErrors = true;
            break;
        }
    }

    if (foundErrors) {
        return
    }

    //if didnt have validation and remove errors contents from previos
    $("#custom-errors").empty()

    let fullName = $("#checkoutFullName").val();
    let email = $("#checkoutEmail").val();
    let phone = $("#checkoutPhone").val();
    let city = $("#checkoutCity option:selected").text();
    let address = $("#checkoutAddress").val();
    let note = $("#checkoutNote").val();
    let cartId = $("#CartId").val();

    $("#checkout-submit").attr("disabled")
    $.LoadingOverlay("show");

    $.ajax({
        type: "POST",
        url: "api/checkout",
        data: JSON.stringify({
            fullName: fullName,
            email: email,
            phone: phone,
            city: city,
            address: address,
            note: note,
            cartId: cartId
        }),
        dataType: "application/json",
        contentType: "application/json",
        success: function (data, status) {
            $.LoadingOverlay("hide");
            window.location.href = "../?success=Checkout was successful";
        },
        error: function (xhr, data, status) {
            $("#checkout-submit").removeAttr("disabled")
            $.LoadingOverlay("hide");

            var error = JSON.parse(xhr.responseText).errors

            $("#custom-errors")
                .append("<div class='alert alert-danger alert-dismissible fade show' role='alert'>" + error + "</div >")
         
        }
    });

})