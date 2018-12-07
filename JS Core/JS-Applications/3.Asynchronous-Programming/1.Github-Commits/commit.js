function loadCommits() {
  let table = $('#commits');
  let username = $('#username').val();
  let repo = $('#repo').val();
  let url = `https://api.github.com/repos/${username}/${repo}/commits`;

  $.ajax({
    method: "GET",
    url
  }).then(function(res) {
    table.empty();
    for (const c of res) {
      table.append($(`<li>${c.commit.author.name}: ${c.commit.message}</li>`))
    }
  }).catch(function(error) {
    table.empty();
    table.append($(`<li>Error: ${error.status} (${error.statusText})</li>`))
  })
}
