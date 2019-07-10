/// <reference path="../../../../types/global.d.ts" />

import "./style.less";

window.kentico.pageBuilder.registerInlineEditor("Company.InlineEditor.ImageUrl", {
    init(options) {
        const editor = options.editor;
        const input = editor.querySelector("input");
        const button = editor.querySelector(".cmp-image-url-apply");

        if (button != null && input != null) {
            button.addEventListener("click", (e) => {
                e.preventDefault();
                var event = new CustomEvent("updateProperty", {
                    detail: {
                        value: input.value,
                        name: options.propertyName
                    }
                });

                editor.dispatchEvent(event);
            });
        }
    },
});