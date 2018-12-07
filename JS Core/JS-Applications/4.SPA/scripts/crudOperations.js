const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_r1MYlgiHm'
const APP_SECRET = '4c0b57fddf12435bb0c44c079bceb328'
const AUTH_HEADERS = {
  'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET)
}
const BOOKS_PER_PAGE = 5


function loginUser() {
  let username = $('#formLogin input[name="username"]').val();
  let password = $('#formLogin input[name="passwd"]').val();
  $.ajax({
    method: 'POST',
    url: BASE_URL + 'user/' + APP_KEY + '/login',
    headers: AUTH_HEADERS,
    data: {
      username,
      password
    }
  }).then(function(res) {
    signInUser(res, "Login successful")
  }).catch(handleAjaxError);
}

function registerUser() {
  let username = $('#formRegister input[name="username"]').val();
  let password = $('#formRegister input[name="passwd"]').val();
  console.log(username);
  console.log(password);
  $.ajax({
    method: "POST",
    url: BASE_URL + 'user/' + APP_KEY + '/',
    headers: AUTH_HEADERS,
    data: {
      username,
      password
    }
  }).then(function(res) {
    signInUser(res, "Registration successful.")
  }).catch(handleAjaxError)

  // POST -> BASE_URL + 'user/' + APP_KEY + '/'
  // signInUser(res, 'Registration successful.')
}

function listBooks() {
  $.ajax({
    method: 'GET',
    url: BASE_URL + 'appdata/' + APP_KEY + '/books',
    headers: {
      Authorization: "Kinvey " + localStorage.getItem("authToken")
    }
  }).then(function(res) {
    displayPaginationAndBooks(res.reverse())
  }).catch(handleAjaxError);
}


function createBook() {
  let title = $('#formCreateBook input[name="title"]').val();
  let author = $('#formCreateBook input[name="author"]').val();
  let description = $('#formCreateBook textarea[name="description"]').val();

  $.ajax({
    method: 'POST',
    url: BASE_URL + 'appdata/' + APP_KEY + '/books',
    headers: {
      Authorization: "Kinvey " + localStorage.getItem("authToken")
    },
    data: {
      title,
      author,
      description
    }
  }).then(function(res) {
    listBooks();
    showInfo("Book created.")
  }).catch(handleAjaxError)
  // showInfo('Book created.')
}

function deleteBook(book) {
  $.ajax({
    method: 'DELETE',
    url: BASE_URL + 'appdata/' + APP_KEY + '/books/' + book._id,
    headers: {
      Authorization: "Kinvey " + localStorage.getItem("authToken")
    }
  }).then(function (res) {
    listBooks();
    showView('viewBooks');
    showInfo("Book deleted.");
  }).catch(handleAjaxError)
  // DELETE -> BASE_URL + 'appdata/' + APP_KEY + '/books/' + book._id
  // showInfo('Book deleted.')
}

function loadBookForEdit(book) {
  showView('viewEditBook');
    $('#viewEditBook input[name="title"]').val(book.title);
    $('#viewEditBook input[name="author"]').val(book.author);
    $('#viewEditBook textarea[name="description"]').val(book.description);
    $('#viewEditBook input[name="id"]').val(book._id);
}

function editBook() {
  let title = $('#viewEditBook input[name="title"]').val();
  let author = $('#viewEditBook input[name="author"]').val();
  let description = $('#viewEditBook textarea[name="description"]').val();
  let id = $('#viewEditBook input[name="id"]').val();

  $.ajax({
    method: 'PUT',
    url: BASE_URL + 'appdata/' + APP_KEY + '/books/' + id,
    headers: {
      Authorization: "Kinvey " + localStorage.getItem("authToken")
    },
    data: {
      title,
      author,
      description
    }
  }).then(function(res) {
    listBooks();
    showInfo("Book edited.")
  }).catch(handleAjaxError)
}

function saveAuthInlocal(userInfo) {
  localStorage.setItem('authToken', userInfo._kmd.authtoken);
  localStorage.setItem('username', userInfo.username);
  localStorage.setItem('id', userInfo._id);

}

function logoutUser() {
  $.ajax({
    method: 'POST',
    url: BASE_URL + 'user/' + APP_KEY + '/_logout',
    headers: {
      Authorization: "Kinvey " + localStorage.getItem("authToken")
    }
  }).then(function(res) {
    console.log(res);
  }).catch(handleAjaxError);
  localStorage.clear();
  showHideMenuLinks();
  showHomeView();
  showInfo('Logout successful.')
}

function signInUser(res, message) {
  saveAuthInlocal(res);
  showHideMenuLinks();
  showHomeView();
  showInfo(message);
}

function displayPaginationAndBooks(books) {
  showView('viewBooks');
  let pagination = $('#pagination-demo')
  if (pagination.data("twbs-pagination")) {
    pagination.twbsPagination('destroy')
  }
  pagination.twbsPagination({
    totalPages: Math.ceil(books.length / BOOKS_PER_PAGE),
    visiblePages: 5,
    next: 'Next',
    prev: 'Prev',
    onPageClick: function(event, page) {
      $('#books > table tr').each((index, element) => {
        if (index > 0) {
          $(element).remove();
        }
      })
      let startBook = (page - 1) * BOOKS_PER_PAGE
      let endBook = Math.min(startBook + BOOKS_PER_PAGE, books.length)
      $(`a:contains(${page})`).addClass('active')
      for (let i = startBook; i < endBook; i++) {
        let tr = $(`<tr><td>${books[i].title}</td>` +
          `<td>${books[i].author}</td>` +
          `<td>${books[i].description}</td></tr>`);

        $('#books > table').append(tr);
        if (localStorage.getItem('id') === books[i]._acl.creator) {

          let td = $('<td>');
          let aDel = $('<a href="#">[Delete]</a>').on('click', function () {
            deleteBook(books[i])
          });
          let aEdit = $('<a href="#">[Edit]</a>').on('click', function () {
            loadBookForEdit(books[i])
          });
          td.append(aDel).append(aEdit);
          tr.append(td);
        }

      }
    }
  })
}

function handleAjaxError(response) {
  let errorMsg = JSON.stringify(response)
  if (response.readyState === 0)
    errorMsg = "Cannot connect due to network error."
  if (response.responseJSON && response.responseJSON.description)
    errorMsg = response.responseJSON.description
  showError(errorMsg)
}
