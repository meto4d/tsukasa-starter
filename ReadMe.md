# Tsukasa-Starter

OBSからkagaminでの配信を可能にするS2MMSHリメイクの[tsukasa](https://github.com/shinji3/tsukasa.exe)をより簡単に実行できるGUIプログラムです。

基本tsukasa同梱のffmpegを実行することを主なシチュエーションとしています。

多分Windows用です。

# 使い方

[ここから](https://github.com/meto4d/tsukasa-starter/release)DLして解凍します。

解凍したtsukasa-starter.exeを実行して、各項目を設定していきます。

最低限必要な設定項目は4つです。
- 左上の*tsukasa(ffmpeg)の場所*の項目にtsukasa同梱のffmpegの場所を設定
- 右上の*鏡置き場URL*欄の右**カスタム**から、鏡置き場設定の画面を開く
- 開いた鏡置き場設定画面にて、鏡置き場URLを左側、ポート番号を右側に入力し、OK
- 戻ったら配信に使用したい鏡置き場URLと置き場ポート番号のプルダウンをそれぞれ設定

後は右下のtsukasa実行ボタンを押し、置き場ページからpush待機設定や、OBSからの配信開始でkagamin配信ができます。


# その他

## portcheckボタン

置き場ポート番号右側にある*portcheck*ボタンは、選択されている鏡置き場URLを確認し、使用できるポート番号を自動で見つけてくる機能です。

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

ffmpegはprocessで実行して、ErrorDataReceivedでffmpegからの応答を受け取っているだけです。
ffmpegの出力文字ってstderrで出力してるんですね。

何かあれば[Twitter@meto4d](https://twitter.com/meto4d)かなん実Vdiscordなどで
