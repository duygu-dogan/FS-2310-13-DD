"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");

let taskListArray = [
    { id: 1, taskDescription: "Netflix İzle", status: "completed" },
    { id: 2, taskDescription: "Pilavı unutma", status: "pending" },
    { id: 3, taskDescription: "Ece'ye kendini affettir", status: "pending" },
    { id: 4, taskDescription: "pazar günü için toplantı planla", status: "completed" },
    { id: 15, taskDescription: "çok kilo verdin, yemek yemeyi unutma!", status: "pending" }
];
//kullanıcının her türlü etkinliği (üstüne gelme, tıklama vs) = event, addEventListener'ın içine önce "" içinde yakalamak istediğimiz event'i, sonra çalışacak fonksiyonu yazıyoruz. isimsiz şekilde fonk. kullanımına "anonim fonk." deniyor
btnAddTask.addEventListener("click", function (event) {
    event.preventDefault(); //ilgili elementin default davranışlarını kaldırır
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let id = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length -1].id + 1;
        taskListArray.push(
            {
                "id": id,
                "taskDescription": value,
                "status" : "pending"
            }
        );
        // console.log(taskListArray);
    } else {
        alert("Lütfen görev alanını boş bırakmayınız!")
    }
    txtTaskDescription.value= ""; //ekleme yaptıktan sonra içini boşalttık
    txtTaskDescription.focus(); //her eklemeden sonra imleci görev ekleme kısmına getirdik
})

function displayTasks() {
    // Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
    taskList.innerHTML="";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0" > Tanımlı göre bulunmamaktadır.</>`;
    }else{
        
    }
}

displayTasks();