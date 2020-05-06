# Tsukasa-Starter

OBSからkagaminでの配信を可能にするS2MMSHリメイクの[tsukasa](https://github.com/shinji3/tsukasa.exe)をより簡単に実行できるGUIプログラムです。

基本的に***tsukasa同梱のffmpeg***を実行することを主なシチュエーションとしています。  
多分Windows用です。

# 使い方

## 必要なもの

- tsukasa同梱のffmpeg  
リンクしません。詳しくは以下の[ffmpeg項](https://github.com/meto4d/tsukasa-starter#ffmpeg)にて
- [この*tsukasa-starter.exe*](https://github.com/meto4d/tsukasa-starter/releases)
[そこから](https://github.com/meto4d/tsukasa-starter/releases)DLして解凍します。  

## 設定すること
解凍したらtsukasa-starter.exeを実行して、各項目を設定していきます。

最低限必要な設定項目は4つです。
- 左上の**tsukasa(ffmpeg)の場所**の項目にtsukasa同梱のffmpegの場所を設定
- 右上の**鏡置き場URL**欄の右***[カスタム]***から、鏡置き場設定の画面を開く
- 開いた鏡置き場設定画面にて、鏡置き場URLを左側、ポート番号を右側に入力し、OK
- 戻ったら配信に使用したい鏡置き場URLと置き場ポート番号のプルダウンをそれぞれ設定

後は右下のtsukasa実行ボタンを押し、置き場ページからpush待機設定や、OBSからの配信開始でkagamin配信ができます。

## 余談
なお、ffmpeg側の問題で、何も言わずに終了することがあります。  
**tsukasa再実行**にチェックを入れておくのを推奨します。  
あと、連打するとバグったので、**tsukasa実行**ボタンは連打禁止っぽい仕様にしてます。

# その他

## ffmpeg
***tsukasa同梱のffmpegのDL先はリンクしません。***  
探してください。  
壺のどこかにあるので、うまあじ紳士の方々には申し訳ないですが、がんばってください。　　
ライセンスのことよくわかってないけど、リンクしてもいいのかな？

一応[tsukasa単体](https://github.com/shinji3/tsukasa.exe)とrtmpが使えるffmpeg単体でも使えます。  
ffmpegパラメータをイジイジしまくると、これ単体で配信もできるはずです。

## portcheckボタン

置き場ポート番号右側にある**[portcheck]**ボタンは、選択されている鏡置き場URLを確認し、使用できるポート番号を自動で見つけてくる機能です。  
一部鏡置き場に利用できないことや、ポート番号の設定を上書きするため、注意してください。

## 配信URL

クリックすると、配信URLをクリップボードにコピーしたり、使いやすいplay.asx付きURLがコピーできたりします。

## ffmpegパラメータ

ffmpegにわたすパラメータの設定ができます。  
各設定項目に自動で置換してくれます。  
`<RTMP>`もしくは`%input%`をここに設定すると、rtmpURL項の文字列に置換されます。  
`<KAGAMI>`もしくは`%output%`をここに設定すると、鏡配信URL項の文字列に置換されます。  

## 余談

細かい部分はデバッグしていません。  
記憶が正しければ、各リストの編集画面にて、空欄にして項目を消すときにバグるはずです。

ffmpegはprocessで実行して、ErrorDataReceivedでffmpegからの応答を受け取っているだけです。  
ffmpegの出力文字ってstderrで出力してるんですね。

何かあれば[Twitter@meto4d](https://twitter.com/meto4d)かなん実Vdiscordなどで
