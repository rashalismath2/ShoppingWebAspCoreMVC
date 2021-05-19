

$("#add-to-cart-submit").on("click", function (e) {
    e.preventDefault()


    let productProductId = $("#Product_ProductId").val();
    let cartItemColor = $('input[name="CartItem.Color"]:checked').val();
    let cartItemSize = $('input[name="CartItem.Size"]:checked').val();
    let cartItemQty = $("#CartItem_Qty option:selected").text();
    let productTitle = $("#Product_Title").val();
    let cartId = $("#CartItem_CartId").val();

    $("#checkout-submit").attr("disabled")
    $.LoadingOverlay("show");
    $("#custom-success")
        .text("")
    $("#custom-errors")
        .text("")

    $.ajax({
        type: "POST",
        url: "/api/products",
        data: JSON.stringify({
            Product: {
                ProductId: productProductId,
                Title: productTitle
            },
            CartItem: {
                Color: cartItemColor,
                Size: cartItemSize,
                Qty: cartItemQty,
                CartId: cartId
            }
        }),
        contentType: "application/json",
        success: function (res, status) {

            $("#cart-item-count").text(res.data)

            $("#custom-success")
                .text("Product was added to the cart")
            $.LoadingOverlay("hide");
        },
        error: function (xhr, data, status) {
            $.LoadingOverlay("hide");
            var error = JSON.parse(xhr.responseText).error
            $("#custom-errors")
                .text(error)
        }
    });

})