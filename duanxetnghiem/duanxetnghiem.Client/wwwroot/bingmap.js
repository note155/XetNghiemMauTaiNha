window.initializeMap = function (diachi1, diachi2) {
    var map = new Microsoft.Maps.Map('#myMap', {
        credentials: 'YOUR_BING_MAPS_API_KEY'
    });

    // Tạo đối tượng địa chỉ từ chuỗi địa chỉ
    var directionsManager = new Microsoft.Maps.Directions.DirectionsManager(map);
    var waypoint1 = new Microsoft.Maps.Directions.Waypoint({ address: diachi1 });
    var waypoint2 = new Microsoft.Maps.Directions.Waypoint({ address: diachi2 });

    // Thêm điểm đến vào DirectionsManager
    directionsManager.addWaypoint(waypoint1);
    directionsManager.addWaypoint(waypoint2);

    // Thiết lập các tùy chọn đường đi và hiển thị đường đi
    directionsManager.setRenderOptions({ itineraryContainer: '#directionsItinerary' });

    // Tìm đường đi và hiển thị nó trên bản đồ
    directionsManager.calculateDirections();
};
