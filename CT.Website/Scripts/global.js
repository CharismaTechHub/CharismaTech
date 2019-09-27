function adjustServicesComponent(width) {
    width = parseInt(width);
    if (width < 992) {
        var serviceItem = $(".form-item.col-md-4.col-md-4-custom.swapped");
        if (serviceItem != undefined && serviceItem.length != 0) {
            var subItems = serviceItem.children();
            subItems = subItems.get().reverse();
            serviceItem.empty().append(subItems);
            serviceItem.removeClass('swapped');
            serviceItem.addClass('no-swapped');
        }
    }
    else{
        var serviceItem = $(".form-item.col-md-4.col-md-4-custom.no-swapped");
        if (serviceItem != undefined && serviceItem.length != 0) {
            var subItems = serviceItem.children();
            subItems = subItems.get().reverse();
            serviceItem.empty().append(subItems);
            serviceItem.removeClass('no-swapped');
            serviceItem.addClass('swapped');
        }
    }
}

$(function () {
    adjustServicesComponent($(this).width());
    $(window).resize(function () {
        adjustServicesComponent($(this).width());
    });
});