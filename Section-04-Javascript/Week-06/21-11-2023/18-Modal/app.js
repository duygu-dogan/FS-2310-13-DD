"use strict";
const btnOpenModal = document.getElementById("btn-open-modal");
const mainModal = document.querySelector(".main-modal");
const btnCloseModal = document.querySelector(".btn-close-modal");
const btnNoModal = document.querySelector(".btn-no-modal");



btnOpenModal.addEventListener("click", function() {
    mainModal.classList.remove("main-modal-none");
});
btnCloseModal.addEventListener("click", closeModal);
btnNoModal.addEventListener("click", closeModal);
mainModal.addEventListener("click", function(event){
    // if(event.target.className == "main-modal"){
    //     closeModal();
    // }
    // if(event.target.classList.contains("main-modal")){
    //     closeModal();
    // };
    if (event.target == mainModal) { 
        // closeModal();
    }
        console.log(event.target);
});

function closeModal() {
    mainModal.classList.add("main-modal-none");
};

