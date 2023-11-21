"use strict";
const btnOpenModal = document.getElementById("btn-open-modal");
const mainModal = document.querySelector(".main-modal");
const btnCloseModal = document.querySelector(".btn-close-modal");
const btnNoModal = document.querySelector(".btn-no-modal");
console.log(mainModal);


btnOpenModal.addEventListener("click", function() {
    mainModal.classList.remove("main-modal-none");
});
btnCloseModal.addEventListener("click", closeModal);
btnNoModal.addEventListener("click", closeModal);
mainModal.addEventListener("click", function(e){
    // if(e.target.className == "main-modal"){
    //     closeModal();
    // }
    // if(e.target.classList.contains("main-modal")){
    //     closeModal();
    // };
    if (e.target == mainModal) { 
        closeModal();}
});

function closeModal() {
    mainModal.classList.add("main-modal-none");
};

