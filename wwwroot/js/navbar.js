$(".handel").on('click', function(){
    $("ul").toggleClass("stretch");
});

// $(document).click(function(e){
//     if (!$(e.target).is(".handel")) {
//          $("ul").removeClass("stretch");          
//   }
// });
//open signup
$(".signup").on('click', function(){
    $('#modal-wrapper').css({display: "block"});
    $("ul").removeClass("stretch");
});
//close signup
$(".close").on('click', function(){
    $('#modal-wrapper').css({display: "none"});
});
//If user clicks anywhere outside of the modal, Modal will close
$(document).click(function(e){
    if (!$(e.target).is(".signup")) {
        if (!$(e.target).parents().andSelf().is('.modal-content')){
            $('#modal-wrapper').css({display: "none"});
        }       
  }
});


