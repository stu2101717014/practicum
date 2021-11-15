let jquery = require('jquery');
window.$ = window.jQuery = jquery;

let requestURL = 'http://localhost:17519';

let queryParams = {"IsCute": false, "IsSmart" : false, "IsEducated":false, "UseCheckBoxesForFilteringData": false, "DogBreed":"All"};

let receivedData = [];

$('#button-header-small-cards').click(function (ev){
  if (ev !== undefined) {
    ev.preventDefault();
  }
  displayDogsLargeGrid();
});

$('#button-header-grid').click(function (ev){
  if (ev !== undefined) {
    ev.preventDefault();
  }
  displaySmallGrid();
});

function displaySmallGrid(){
  $('#dogs-grid-large-icons-container').remove();
  $('#dogs-grid-small-icons-container').remove();
  $('#form-dogs').remove();


  let container = $('<div class="container" id="dogs-grid-small-icons-container"></div>');
  let table = $('<table class="table mb-4"></table>');
  let head = $('<thead></thead>');
  let body = $('<tbody> </tbody>');

  for (let i = 0; i < receivedData.length; i++) {
    let tableRow = $('<tr></tr>');
    for (const [key, val] of Object.entries(receivedData[i])) {
        if (key.toLowerCase() !== 'image' && key.toLowerCase() !== 'smallimage'){
          $(tableRow).append('<td>' + key + ' : ' + val + '</td>');
        }
        if(key.toLowerCase() === 'smallimage'){
          $(tableRow).append('<img src="data:image/png;base64,'+ val + '"  alt="..." >');
        }
    }
    $(body).append(tableRow);
  }
  $(table).append(head);
  $(table).append(body);
  $(container).append(table);
  $(document.body).append(container);
}

$('#button-header-form').click(function (ev){

  $('#dogs-grid-large-icons-container').remove();
  $('#dogs-grid-small-icons-container').remove();
  $('#form-dogs').remove();

  createDogsForm();
})

function displayDogsLargeGrid(){
  $('#dogs-grid-large-icons-container').remove();
  $('#dogs-grid-small-icons-container').remove();
  $('#form-dogs').remove();


  let container = $('<div className="container" id="dogs-grid-large-icons-container"className="form-request-stage-two"></div>');

  for (let i = 0; i < receivedData.length; i+=3) {

    let row = $('    <div className="row">\n </div>');
      for (let j = 0; j < 3 && (i + j) < receivedData.length; j++){

          let cell = $('     <div class="card" style="width: 18rem;">\n' +
            '       <img src="data:image/png;base64,'+ receivedData[i + j]['image'] + '" class="card-img-top form-request-stage-two" alt="...">\n' +
            '       <div class="card-body form-request-stage-two">\n' +
            '         <p class="card-text form-request-stage-two">'
                        + 'Is cute :' + ' ' + receivedData[i + j]['isCute'] + '<br>' +
                          'Is smart :' + ' ' + receivedData[i + j]['isSmart'] + '<br>' +
                          'Is educated :' + ' ' + receivedData[i + j]['isEducated'] + '<br>' +
            '         </p>\n' +
            '       </div>\n' +
            '     </div>\n');
          $(row).append(cell);
      }
      $(container).append($(row));
  }
  $(document.body).append(container);
}

function getDogs(ev){
  if (ev !== undefined) {
    ev.preventDefault();
  }
  ajaxGetDogs( displayDogsLargeGrid)
}

function ajaxGetDogs (successFun){

  let params = '';
  for (let key in queryParams){
    params += key + '=' + queryParams[key] + '&';
  }
  params = params.substring(0, params.length - 1);

  $.ajax({
    url: requestURL + '/api/Dogs/params' + '?' + params,
    headers: {
      'Content-Type': 'application/x-www-form-urlencoded'
    },
    type: 'GET',
    dataType: 'json',
    success: function (result) {
      receivedData = result;
      successFun(result);
    },
    error: function (result) {
      console.log(result);
    }
  });
}

function checkBoxSetDogProp(ev){
  let param = ev.target.id;
  let value = $('#' + ev.target.id).is(':checked');
  queryParams[param] = value;
}

function dropDownSetDogProp(ev){
  changeClassesOfClickedButton();
  let param = 'DogBreed';
  let value = ev.target.id;
  queryParams[param] = value;
}

function changeClassesOfClickedButton() {
  let classes = $('#dog-breed-drop-down-button').attr("class");
  if (!classes.toString().includes('show')){
    $('#dog-breed-drop-down-button').addClass('show');
    $('#drop-down-ul-dog-breed').addClass('show');
  }else {
    $('#dog-breed-drop-down-button').removeClass('show')
    $('#drop-down-ul-dog-breed').removeClass('show')
  }
}

function formDataReceived(result) {
  let form = $('#form-dogs')[0];

  let formUndefined = false;
  if (form === undefined){
    formUndefined = true;
    form = $('<form id="form-dogs"></form>')
  }

  let dropdown = $('<div class="dropdown ">\n' +
    '  <button class="btn btn-secondary dropdown-toggle" type="button" id="dog-breed-drop-down-button" data-bs-toggle="dropdown" aria-expanded="false" >\n' +
    '    Include Breeds\n' +
    '  </button>\n' +
    '  <ul class="dropdown-menu" aria-labelledby="dropdownMenu2" id="drop-down-ul-dog-breed">\n' +
    '  </ul>\n' +
    '</div>');

  $(dropdown).find('#dog-breed-drop-down-button').click(changeClassesOfClickedButton);
  for (let el in result) {
    if (result[el].item1 === 'DogBreed') {
      $(dropdown).find('#drop-down-ul-dog-breed')
        .append('<li style="float:left"><a class="dropdown-item" href="#" + id="' + result[el].item2 + '">' + result[el].item2 + '</a></li>');
      $(dropdown).find('#' + result[el].item2).click(dropDownSetDogProp)
    }
  }
  $(form).prepend(dropdown);
  for (let el in result) {
    if (result[el].item1 !== 'DogBreed') {
      let divEl = $('<div class="mb-3">\n' +
        '    <label class="form-label">' + result[el].item1 + '</label>\n' +
        '    <input type="checkbox" class="form-check-input" checked="' + queryParams[result[el].item2] +'" id="' + result[el].item1 + '" >\n' +
        '  </div>\n');
      $(divEl).find('#' + result[el].item1).click(checkBoxSetDogProp);
      $(divEl).find('#' + result[el].item1).prop('checked', queryParams[result[el].item1]);
      $(form).prepend(divEl);
    }
  }

  let divEl = $('<div class="mb-3">\n' +
    '    <label class="form-label">' + 'UseCheckBoxesForFilteringData' + '</label>\n' +
    '    <input type="checkbox" class="form-check-input"  id="' + 'UseCheckBoxesForFilteringData' + '" >\n' +
    '  </div>\n');
  $(divEl).find('#' + 'UseCheckBoxesForFilteringData').click(checkBoxSetDogProp)
  $(form).prepend(divEl);

  $(divEl).find('#UseCheckBoxesForFilteringData').prop('checked', queryParams.UseCheckBoxesForFilteringData);

  if (formUndefined){
    let dogSubmitBtn = $('<button type="submit" class="btn btn-primary" id="submit-form-button" >Submit</button>');
    $(dogSubmitBtn).click(getDogs);
    $(form).append(dogSubmitBtn);
    $(document.body).append(form);
  }
}

function createDogsForm (event) {
  if (event !== undefined) {
    event.preventDefault();
  }

  $.ajax({
    url: requestURL + '/api/Params',
    headers: {
      'Content-Type': 'application/x-www-form-urlencoded'
    },
    type: 'GET',
    dataType: 'json',
    success: function (result) {
      formDataReceived(result);
    },
    error: function (result) {
      console.log(result);
    }
  });

  $('#submit-form-button').click(getDogs);
}

document.addEventListener('DOMContentLoaded', createDogsForm);
