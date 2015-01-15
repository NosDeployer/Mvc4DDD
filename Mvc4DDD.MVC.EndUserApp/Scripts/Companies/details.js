function showMap(xcoord, ycoord) {
    var myCenter = new google.maps.LatLng(xcoord, ycoord);

    var mapProp = {
        center: myCenter,
        scrollwheel: false,
        zoom: 15,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);

    var marker = new google.maps.Marker({
        position: myCenter,
    });

    marker.setMap(map);
}

function friendlyPhones(s) {
    if (s.trim() === "-" || !s) return s;

    var list = s.split(";");
    for (var i = 0; i < list.length; i++) {
        list[i] = "+" + list[i];
    }

    return list.join("<br/>");
}

function friendlyOp(s) {
    if (s.trim() === "-" || !s) return s;

    var list = s.split(";");
    for (var i = 0; i < list.length; i++) {
        var day = list[i].trim()[0];
        list[i] = list[i].replace(day, codeToDay(day));
    }

    return list.join("<br/>");
}

function codeToDay(code) {
    switch (code) {
    case "E":
        return "Monday";
    case "T":
        return "Tuesday";
    case "K":
        return "Wednesday";
    case "N":
        return "Thursday";
    case "R":
        return "Friday";
    case "L":
        return "Saturday";
    case "P":
        return "Sunday";
    default:
        return "Unknown";
    }
}
    

$(document).ready(function () {

    $.ajaxSetup({
        cache: false
    });

    $("#addPhones").html(friendlyPhones($("#addPhones").text()));
    $("#mainPhone").html(friendlyPhones($("#mainPhone").text()));
    $("#fax").html(friendlyPhones($("#fax").text()));
    $("#openingH").html(friendlyOp($("#openingH").text()));

    $('#mapButton').click(function () {

        $('#mapButton').prop("disabled", true);
        $.ajax({
            type: "POST",
            url: "/Companies/GetCoords",
            data: { id: companyId },
            success: function (ret) {
                if (ret.ok) {
                    $('#googleMap').slideDown({
                        complete: function () {
                            showMap(ret.xcoord, ret.ycoord);
                            $('#mapButton').prop("disabled", false);
                        }
                    });
                } else {
                    alert("Sorry! An error occurred.");
                }
            }

        });

    });
});