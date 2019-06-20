(function () {
    // Registers the 'custom-editor' inline property editor within the page builder scripts
    window.kentico.pageBuilder.registerInlineEditor("text-area-inline-editor", {
        init: function (options) {
            var editor = options.editor;
            var area = editor.querySelector('textarea');
            area.value = options.propertyValue;
            area.addEventListener('change', function (e) {
                var event = new CustomEvent("updateProperty", {
                    detail: {
                        value: e.target.value,
                        name: options.propertyName
                    }
                });
                editor.dispatchEvent(event);
            });
        }
    });
})();