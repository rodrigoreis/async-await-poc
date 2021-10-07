#!/bin/bash

CSPROJ="{ADD YOUR PROJECT NAME HERE}"
DOTNET_RUNTIME="ubuntu-x64"
OUTPUT_DIR="${PWD}/output"
CSPROJ_PATH="${PWD}/src/${CSPROJ}/${CSPROJ}.csproj"
BUILD_SELF_CONTAINED=true
BUILD_SINGLE_FILE=true

rm -rf $OUTPUT_DIR 2> /dev/null
mkdir $OUTPUT_DIR -p

echo "🩹 Restoring NuGet packages ..."
dotnet restore $CSPROJ_PATH --runtime $DOTNET_RUNTIME

echo "📦 Building ${CSPROJ_PATH} ..."
dotnet publish $CSPROJ_PATH -c Release -o $OUTPUT_DIR --no-restore --runtime $DOTNET_RUNTIME --self-contained $BUILD_SELF_CONTAINED -p:PublishSingleFile=$BUILD_SINGLE_FILE -p:PublishReadyToRun=true

echo "🧹 Clean *.pdb files from output ..."
rm "${OUTPUT_DIR}/*.pdb" 2> /dev/null

echo "⚙️  Creating run.sh"
echo "#!/bin/bash" >${PWD}/run.sh
echo "${OUTPUT_DIR}/${CSPROJ}" >>${PWD}/run.sh
chmod +x ${PWD}/run.sh

echo "✔️ Done"
