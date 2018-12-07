function attachEvents() {
  const URL = 'https://baas.kinvey.com/appdata/kid_ByTx0h9r7/';
  const USERNAME = 'Peter';
  const PASSWORD = 'p';
  const BASE_64 = btoa(USERNAME + ":" + PASSWORD);
  const AUTH = {"Authorization": 'Basic ' + BASE_64};
  const SELECT = $('#posts');
  const TITLE = $('#post-title');
  const BODY = $('#post-body');
  const COMMENTS = $('#post-comments');

  $('#btnLoadPosts').on('click', loadPosts);
  $('#btnViewPost').on('click', viewPost);

  function loadPosts() {
    $.ajax({
      method: 'GET',
      url: URL + 'posts',
      headers: AUTH
    }).then(function(res) {
      SELECT.empty();
      for (const post of res) {
        SELECT.append($(`<option id="${post._id}" body="${post.body}">${post.title}</option>`));
      }
    }).catch(function(err) {
      console.log(err);
    });
  }

  function viewPost() {
    let selected = SELECT.find(':selected');


    $.ajax({
      method: 'GET',
      url: URL + `comments/?query={"post_id":"${selected.attr('id')}"}`,
      headers: AUTH
    }).then(function(res) {
      TITLE.text(selected.text());
      BODY.html($(`<li>${selected.attr('body')}</li>`));
      COMMENTS.empty();
      for (const comment of res) {
        COMMENTS.append($(`<li>${comment.text}</li>`))
      }
    }).catch(function(res) {
      console.log(err);
    })
  }
}
