const glob = require('glob');
const path = require('path');
const constants = require("./constants");

module.exports = {
  getSourceOutputMappings(isProduction) {
    const sourceFiles = glob.sync(path.resolve(__dirname, "../") + `/**/${constants.SOURCE_FILES_FOLDER_NAME}/**/${constants.ENTRY_FILE_NAME}`);
    
    return sourceFiles.map(sourceFilePath => sourceFilePath.split(constants.SOLUTION_FOLDER_NAME)[1])
      .reduce((mappings, filePath) => {
        const componentFolderName = filePath.split("/")[1];
        const componentContentPath = `.${path.dirname(filePath.split(constants.SOURCE_FILES_FOLDER_NAME)[1])}`;
        const outputPath = isProduction ? 
          path.resolve(__dirname, "../", `${componentFolderName}/${constants.OUTPUT_FOLDER_NAME}`, componentContentPath) :
          path.resolve(__dirname, "../", constants.DEV_OUTPUT_PATH, componentContentPath);

        mappings[`.${filePath}`] = outputPath;
        return mappings;
      }, {});
  }
}