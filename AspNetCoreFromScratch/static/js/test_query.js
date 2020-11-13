function loadHTTPContent(url, onLoad)
{
    var request = new XMLHttpRequest();

    request.onload = (event) => {

        if (onLoad != null)
            onLoad(request.responseText);
    };

    request.open('GET', url);

    request.send();
}

