
<template>
  <div class="app-browser">
    <section class="browser-body" :style="{height: app.height + 'px'}">
      <iframe v-el:iframe :src="src" name="test" height="100%" width="100%" frameborder="0"></iframe>
    </section>
    </div>
</template>

<script>

export default {
  props: {
    app: true
  },
  data: function () {
    return {
      url: '',
      src: ''
    }
  },
  methods: {
    go: function () {
      if (!$.trim(this.url)) return
      this.iframeGo(this.url)
    },
    iframeGo: function (url) {
      this.src = url
    }
  },
  components: {},
  ready: function () {
    if (this.app.data) {
      this.url = this.app.data.index
      this.fixUrl()
      this.go()
    }
  }
}
</script>

<style lang="less" rel="stylesheet/less">
.app-browser {
  position: relative;
  height: 100%;
}

@headerHeight: 30px;
.browser-header {
  height: @headerHeight;
  background: #F3F3F3;
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  .browser-control-panel {
    &>div {
      float: left;
      display: block;
      height: @headerHeight;
      width: @headerHeight;
      text-align: center;
      cursor: default;
      &:hover {
        background: #fff;
      }
      &:active {
        background: #eee;
      }
    }
    float:left;
  }

}

.browser-body {
  padding-top: 30px;
}
</style>