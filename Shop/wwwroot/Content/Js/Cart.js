

function deleteSelectedCartItem(button) {
    var cartItemId = button.getAttribute("data-id");

    $.LoadingOverlay("show");

    $.ajax({
        type: "DELETE",
        url: "api/cartitem/" + cartItemId,
        dataType: "application/json",
        success: function (data, status) {
            $.LoadingOverlay("hide");
        },
        error: function (xhr, data, status) {
            $("#checkout-submit").removeAttr("disabled")
            $.LoadingOverlay("hide");

            if (xhr.status == 500) {
                $("#customer-error").removeClass("hide")
                $("#customer-error").text="Something went wrong! Try again"
            }
        },
        complete: function (xhr) {
            if (xhr.status==204) {
                var row = $(`[data-id=${cartItemId}],#cart-item-row`)

                var rowDiscountText = $(`[data-id=${cartItemId}]#cart-item-discount`).text()
                var rowDiscount = parseFloat(rowDiscountText.replace("Rs.", ""))

                var rowSubtotalText = $(`[data-id=${cartItemId}]#cart-item-subtotal`).text()
                var rowSubtotal = parseFloat(rowSubtotalText.replace("Rs.", ""))

                var rowTotalText = $(`[data-id=${cartItemId}]#cart-item-total`).text()
                var rowTotal = parseFloat(rowTotalText.replace("Rs.", ""))

                var discountText = $(`#cart-item-discount-value`).text()
                var discount = parseFloat(discountText.replace("Rs.", ""))

                var subTotalText = $(`#cart-item-subtotal-value`).text()
                var subTotal = parseFloat(subTotalText.replace("Rs.", ""))

                var totalText = $(`#cart-item-total-value`).text()
                var total = parseFloat(totalText.replace("Rs.", ""))

                var finalDiscount = discount - rowDiscount
                var finalSubtotal = subTotal - rowSubtotal
                var finalTotal = total - rowTotal

                $(`#cart-item-discount-value`).text("Rs." + finalDiscount) 
                $(`#cart-item-subtotal-value`).text("Rs." + finalSubtotal)
                $(`#cart-item-total-value`).text("Rs." + finalTotal)

                row.remove()
            }

        }
    });

}