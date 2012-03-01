/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    config.language = 'ru';
    // config.uiColor = '#AADC6E';
    config.filebrowserBrowseUrl = "/Areas/Admin/Plugins/CKfinder/ckfinder.html";
    config.filebrowserImageBrowseUrl = "/Areas/Admin/Plugins/CKfinder/ckfinder.html?type=Images";
    config.filebrowserFlashBrowseUrl = "/Areas/Admin/Plugins/CKfinder/ckfinder.html?type=Flash";
    config.filebrowserUploadUrl = "/Areas/Admin/Plugins/CKfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files";
    config.filebrowserImageUploadUrl = "/Areas/Admin/Plugins/CKfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images";
    config.filebrowserFlashUploadUrl = "/Areas/Admin/Plugins/CKfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash";
    config.filebrowserWindowWidth = "1000";
    config.filebrowserWindowHeight = "700";
};
