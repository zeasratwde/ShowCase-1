
$(document).ready(function () {
    $("#btnHolder").hide();
    $('#tempMessage').delay(3000).fadeOut();
});

function loadData() {

    /*
    Intiailize necessary variables
    */
    var $body = $('#ajaxInner');   
    var $wikiElem = $('#wikipedia-links');
    var $nytHeaderElem = $('#nytimes-header');
    var $nytElem = $('#nytimes-articles');
    var $greeting = $('#greeting');

    // clear out old data before new request
    $wikiElem.text("");
    $nytElem.text("");

    var streetStr = $('#street').val();
    var cityStr = $('#city').val();
    var address = streetStr + ', ' + cityStr;
    
    $("#mCarousel").remove();
    $("#btnHolder").show();
    $().tab('show') //needed to activate bootsrtap tab

    

    $greeting.text('New York Times recent articles about  ' + cityStr );


    // load streetview
    var streetviewUrl = 'https://maps.googleapis.com/maps/api/streetview?size=600x400&location=' + address + '';
    //clear out old image;
    $body.text("");
    $body.append('<img class="bgimg" src="' + streetviewUrl + '">');


    // load nytimes
    
    var nytimesUrl = 'https://api.nytimes.com/svc/search/v2/articlesearch.json?q=' + cityStr + '&sort=newest&api-key=80dce1c8ec293f1a6f3c5926d84d54ff:16:1113477';
    $.getJSON(nytimesUrl, function(data){

        $nytHeaderElem.text('New York Times Articles About ' + cityStr);

        articles = data.response.docs;
        for (var i = 0; i < articles.length; i++) {
            var article = articles[i];
            $nytElem.append('<li class="article">'+
                '<a href="'+article.web_url+'">'+article.headline.main+'</a>'+
                '<p>' + article.snippet + '</p>'+
            '</li>');
        };

    }).error(function(e){
        $nytHeaderElem.text('New York Times Articles Could Not Be Loaded');
    });


    // load wikipedia data
    var wikiUrl = 'https://en.wikipedia.org/w/api.php?action=opensearch&search=' + cityStr +
        'php?action=opensearch&search=' + cityStr + '&format=json&callback=wikiCallback';
   
    $.ajax({
        url: wikiUrl,
        dataType: "jsonp",
        //jsonp: "callback",
        success: function (response) {
            var articleList = response[1];

            for (var i = 0; i < articleList.length; i++) {
                articles = articleList[i];
                var url = 'https://en.wikipedia.org/wiki/' + articles;
                $wikiElem.append('<li><a href="' + url + '">' + articles + '</a></li>');
            }
        }
    });
   

    return false;
};

$('#form-container').submit(loadData);


//for hover drop
$(function () {
    $(".dropdown").hover(
            function () {
                $('.dropdown-menu', this).stop(true, true).fadeIn("fast");
                $(this).toggleClass('open');
                $('b', this).toggleClass("caret caret-up");
            },
            function () {
                $('.dropdown-menu', this).stop(true, true).fadeOut("fast");
                $(this).toggleClass('open');
                $('b', this).toggleClass("caret caret-up");
            });
});

$(function () {
    $('[data-toggle="tooltip"]').tooltip();
    $('[data-toggle="popover"]').popover();
    $('#demoScrollspy').on('activate.bs.scrollspy', function () {
        // do something…
    })

// for addding ajax capability to the paged list
    $('#linkContentPage').on('click', 'a', function () {
        $.ajax({
            url: this.href,
            type: 'GET',
            cache: false,
            success: function (result) {
                $('#pagedContent').html(result);
            }
        });
        return false;
    });


    });

