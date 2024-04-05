function initMap() {
    // Initialize map with center at Hue city
    var map = new Microsoft.Maps.Map(document.getElementById('bingMap'), {
        credentials: 'AvJeIjn2sAoBGbyZw0PImFkcys5P60orulBL-i8ArqPp96C4h2_CL2xmY0YuJehi',
        center: new Microsoft.Maps.Location(16.4637, 107.5909), // Coordinates of Huế city
        zoom: 12 // Zoom level (adjust as needed)
    });

    Microsoft.Maps.loadModule('Microsoft.Maps.Search', function () {
        var searchManager = new Microsoft.Maps.Search.SearchManager(map);
        // Geocode all addresses in the list
        @foreach(var address in allDon)
    {
        <text>
            searchManager.geocode({
                where: "@address.diachi",
            callback: function (geocodeResult) {
                            if (geocodeResult && geocodeResult.results && geocodeResult.results.length > 0) {
                                var location = geocodeResult.results[0].location;
            var pin = new Microsoft.Maps.Pushpin(location, {
                title: 'Địa chỉ',
            subTitle: "@address.nguoi.Hoten"
                                });
            map.entities.push(pin);

            Microsoft.Maps.Events.addHandler(pin, 'click', function () {
                                    var content = `<div class="alert alert-success"> <strong>Thông tin khách hàng: </strong>@address.nguoi.Hoten</div>
            <p><strong>Số điện thoại: </strong>@address.nguoi.SDT</p>
            <p><strong>Địa chỉ: </strong>@address.diachi</p>
            <p><strong>Email: </strong>@address.nguoi.Email</p>
            <p><strong>Thời gian: </strong>@address.dxn.giolaymau @address.dxn.Ngaydat.ToString("dd/MM/yyyy")</p>`;


            showInfoWindow(content);
            CSMethod1(@address.dxn.Id);
                                });
                            }
                        }
                    });
        </text>
    }
});

    }
function CSMethod1(content) {
    DotNet.invokeMethodAsync('duanxetnghiem.Client', 'CSCallBackMethod', content).then(data => {
        console.log(data);
    });
}

function toggleInfoWindow() {
    var infoWindow = document.getElementById("infoWindow");
    infoWindow.classList.toggle("show");
}
function toggleInfoWindowtat() {
    var infoContent = document.getElementById("infoContent");
    infoContent.innerHTML = "";
    toggleInfoWindow();
}
function showInfoWindow(content) {
    var infoContent = document.getElementById("infoContent");
    infoContent.innerHTML = content;
    toggleInfoWindow();
}