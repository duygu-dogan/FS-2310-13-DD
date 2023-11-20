"use strict";
const txtTaskDescription = document.getElementById("txt-task-description");
const btnAddTask = document.getElementById("btn-add-task");
const taskList = document.getElementById("task-list");
const btnClearAll = document.getElementById("btn-clear-all");
const filters = document.querySelectorAll("#filters span");

let isEditMode = false; //Eğer bu değişken false ise yeni kayıt modu, true ise düzenleme modundayız.
let editedTaskId; //o anda hangi görev düzenleniyor ise uygulama boyunca geçerli olacak şekilde o görevin id'sini tutmaya yarar.
let filterMode = "all";

let taskListArray = [];

//kullanıcının her türlü etkinliği (üstüne gelme, tıklama vs) = event, addEventListener'ın içine önce "" içinde yakalamak istediğimiz event'i, sonra çalışacak fonksiyonu yazıyoruz. isimsiz şekilde fonk. kullanımına "anonim fonk." deniyor

//btnAddTask elementine click yapıldığında çalışacak fonk. adı addTask
btnAddTask.addEventListener("click", addTask);

//btnClearAll elementine click yapıldığında çalışacak fonk. clearAll
btnClearAll.addEventListener("click", clearAll);

//Yeni görev ekleyen fonksiyon
function addTask(event) {
    event.preventDefault(); //ilgili elementin default davranışlarını kaldırır
    let value = txtTaskDescription.value.trim();
    if (value != "") {
        let idNumber = taskListArray.length == 0 ? 1 : taskListArray[taskListArray.length - 1].id + 1;
        taskListArray.push(
            {
                "id": idNumber,
                "taskDescription": value,
                "status": "pending"
            }
        );
        displayTasks(filterMode)
        setTasks();
    } else {
        alert("Lütfen görev açıklamasını boş bırakmayınız!")
    }
    txtTaskDescription.value = ""; //ekleme yaptıktan sonra içini boşalttık
    txtTaskDescription.focus(); //her eklemeden sonra imleci görev ekleme kısmına getirdik
};

// Bu function, her ihtiyaç duyulduğunda tüm görevleri yeniden okuyup ekranda göstermek için kullanılacak.
function displayTasks(filter) {
    taskList.innerHTML = "";
    if (taskListArray.length == 0) {
        taskList.innerHTML = `<div class="alert alert-warning mb-0" > Tanımlı görev bulunmamaktadır.</>`;
    } else {
        for (const task of taskListArray) {
            let completed = task.status == "completed" ? "checked" : "";
            if(filter=="all" || filter==task.status){
                let taskLi = `
            <li class="task list-group-item">
                <div class="form-check d-flex justify-content-between align-items-center" id="${task.id}">
                    <input onclick="updateStatus(this);" type="checkbox" id="${task.id}" class="form-check-input" ${completed}>
                    <div class="input-group">
                        <input id="${task.id}" class="form-control ${completed}" type="text" value="${task.taskDescription}"
                            disabled />
                            <button onclick="editTask(this);" id="${task.id}" class="btn btn-warning"><i class="fa-solid fa-pen-to-square"></i></button>
                            <button onclick="deleteTask(this);" id="${task.id}" class="btn btn-danger"><i class="fa-solid fa-trash"></i></button>
                    </div>
                </div>
            </li>
            `;
                taskList.insertAdjacentHTML("beforeend", taskLi);
            }
        }
    }
}


//task update (tamamlandı/devam ediyor) işlemini yapan fonk.)
function updateStatus(activeTask) {
    let newStatus = activeTask.checked ? "completed" : "pending";
    for (const task of taskListArray) {
        if (activeTask.id == task.id) {
            task.status = newStatus;
            break;
        };
    };
    displayTasks(filterMode);
    setTasks();
}

//Araştırma Ödevi: cursor nasıl sona getirilir veya seçili halde gösterilir cevap: setSelectionRange(); başlangıç ve son index o.ü. iki parametre alıyor.
//Araştırma Ödevi: Bir taskı düzenleme modundayken diğerlerine tıklamayı engelle

//İlgili Görevin düzenlenmesini yapar
function editTask(clickedButton) {
    editedTaskId = clickedButton.id;
    let editedTask = clickedButton.previousElementSibling;
    let checked;
    for (const task of taskListArray) {
        if (task.id == editedTaskId) {
            checked = task.status;
        }
    }
    if (!isEditMode) {
        editedTask.removeAttribute("disabled");
        if (checked == "completed") editedTask.classList.remove("checked");
        clickedButton.classList.remove("btn-warning");
        clickedButton.classList.add("btn-info");
        // clickedButton.firstElementChild.classList.remove("fa-pen-to-square");
        // clickedButton.firstElementChild.classList.remove("fa-solid");
        // clickedButton.firstElementChild.classList.add("fa-circle-check");
        // clickedButton.firstElementChild.classList.add("fa-regular");
        clickedButton.innerHTML = `<i class = "fa-regular fa-circle-check"></i>`;
        const end = editedTask.value.length;
        editedTask.setSelectionRange(0, end);
        editedTask.focus();
        isEditMode = true;
    } else {
        editedTask.setAttribute("disabled", "disabled");
        if (checked == "completed") editedTask.classList.add("checked");
        clickedButton.classList.remove("btn-info");
        clickedButton.classList.add("btn-warning");
        clickedButton.innerHTML = `<i class="fa-solid fa-pen-to-square"></i>`;
        for (const task of taskListArray) {
            if (editedTaskId == task.id) {
                task.taskDescription = editedTask.value;
                break;
            }
        }
        isEditMode = false;
        displayTasks(filterMode);
        setTasks();
    }
}
//İlgili görevi siler
function deleteTask(clickedButton) {
    let deletedTaskId = clickedButton.id;
    let deletedTask = taskListArray.filter(function (task) {
        if (deletedTaskId == task.id) return true;
    });
    let deletedTaskDescription = deletedTask[0].taskDescription;
    console.log(deletedTaskDescription);
    let answer = confirm(`'${deletedTaskDescription}' görevi silinecektir!`);
    if (answer) {
        let index = taskListArray.indexOf[deletedTask[0]];
        taskListArray.splice(index, 1);
        setTasks();
        displayTasks(filterMode);
        alert("Silme işlemi başarıyla tamamlanmıştır.");
    }
}

//tüm görevleri siler
function clearAll() {
    let answer = confirm("Tüm görevler silinecektir!");
    if (answer) {
        // taskListArray = [];
        taskListArray.splice(0);
        displayTasks(filterMode);
        setTasks();
    }
}

//filters içindeki spanlara click eventlerini atar
function assignSpansEvents(){
    for (const span of filters) {
        span.addEventListener("click", function(){
            let activeSpan = document.querySelector("span.active");
            activeSpan.classList.remove("active");
            span.classList.add("active");
            filterMode = span.id;
            displayTasks(filterMode);
        });
    };

};

//LocalStorage'daki datamızı okuyup dizimizin içine aktaracak.
function getTasks(){
    //Task'lerimiz LocalStorage'de TaskList adında bir key'in içinde tutulacak.
    let TaskListItem = localStorage.getItem("TaskList")
    if(TaskListItem!=null){
        taskListArray = JSON.parse(TaskListItem);
    };
};
function setTasks(){
    localStorage.setItem("TaskList", JSON.stringify(taskListArray));
};

getTasks();
assignSpansEvents();
displayTasks(filterMode);



//Araştırma ödevi: Görev adına tıkladığımızda da completed ya da pending şeklinde status değişimi olmasını nasıl sağlarız?