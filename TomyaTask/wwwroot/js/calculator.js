
$(document).ready(function() {

    var girilenTus = "0";
    var anaMetin = "0";
    $("button").click(function() {
        girilenTus = $(this).attr("value");


        if (girilenTus != "=" && girilenTus != "ac") {


            if (isNaN(anaMetin[anaMetin.length - 1]) && isNaN(girilenTus)) {

                anaMetin = anaMetin.substring(0, anaMetin.length - 1);
                anaMetin += girilenTus;
                $("#r2").val(anaMetin);
                $("#previous p").html(anaMetin);


            } else {

                if (anaMetin === "0") {
                    anaMetin = "";
                }
                anaMetin += girilenTus;
                
                $("#r2").val(anaMetin);
                $("#previous p").html(anaMetin);

            }


        } else if (girilenTus === "ac") {
            girilenTus = "0";
            anaMetin = "0";
            $("#r2").val(girilenTus);
            $("#previous p").html(anaMetin);
            $("#result p").html(anaMetin);

        } else {

        }


    });
});

function cleartextboxes() {
    $("input:text").val("");

}