import { debounce } from "debounce";

export interface ImageUrlOptions {
    readonly identifier: string;
    readonly controlClassName: string;
    readonly validationClassName: string;
    readonly imagePreviewClassName: string;
    readonly placeholderImageUri: string;
}

interface ImageUrlWithPreview {
    readonly init: (options: ImageUrlOptions) => void;
}

interface FormComponents {
    readonly imageUrlWithPreview: ImageUrlWithPreview;
}

export interface Company {
    readonly formComponents: FormComponents;
    readonly debounce: typeof debounce;
    readonly isUrlImage: (url: string) => Promise<boolean>;
}