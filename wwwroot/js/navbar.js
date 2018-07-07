$(".handel").on('click', function(){
    $("ul").toggleClass("stretch");
    
});
//If user clicks anywhere outside of the modal, Modal will close
$(document).click(function(e){
    if (".stretch") {
        if(!$(e.target).parents().andSelf().is('ul')){
         $("ul").removeClass("stretch"); }             
  }
});
//open signup
$(".signup").on('click', function(){
    $('#modal-wrapper').css({display: "block"});
    $('.animate').css( {animation: "zoom1 0.4s"}).on('animationend ', ShowTheElementAfterAnimation);
    $("ul").removeClass("stretch");
});
//close signup
$(".close").on('click', function(){
    $('.animate').css( {animation: "zoom2 0.4s"}).on('animationend ', HideTheElementAfterAnimation);
});
//If user clicks anywhere outside of the modal, Modal will close
$(document).click(function(e){
    if (!$(e.target).is(".signup")) {
        if (!$(e.target).parents().andSelf().is('.modal-content')){
            $('#modal-wrapper').css({display: "none"});
        }       
  }
});

   
function HideTheElementAfterAnimation(){
    $("#modal-wrapper").css("display", "none");
}

function ShowTheElementAfterAnimation(){
    $("#modal-wrapper").css("display", "block");
}


