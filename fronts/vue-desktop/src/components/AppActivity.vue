
<template>
  <div class="activity" ref="main">
    <div class="activity-body">
      <iframe ref="iframe" :src="src" @load="onFrameLoad" name="test" height="100%" width="100%" frameborder="0"></iframe>
    </div>
  </div>
</template>

<script>
// import StartDrag from '../StartDrag'

export default {
  props: ['item'],
  data: function () {
    return {
      url: '',
      src: ''
    }
  },
  watch: {
    src: function (newVal, oldVal) {
      // console.log('iframe src change', newVal, oldVal)
    }
  },
  methods: {
    go: function () {
      // if (!$.trim(this.url)) return
      this.iframeGo(this.url)
    },
    iframeGo: function (url) {
      this.src = url
    },
    onFrameLoad () {
      // console.log('onFrameLoad')
      // console.log(this.$refs.iframe.contentDocument.title)
      this.$engine.call({
        Service: 'ZeroRoo.DefaultApp.Services.ActivityTitleChange',
        Data: {
          Item: this.item,
          NewTitle: this.$refs.iframe.contentDocument.title
        }
      }, res => {
        // console.log('send success')
      })
    }
  },
  components: {},
  mounted () {
    // console.log('AppActivity Mounted', this.item)
    if (this.item) {
      this.url = this.item.Target
      this.go()
    }
  }
}
</script>

<style lang="stylus">
.activity {
  height 100%
  display flex
  width 100%
}
.activity-body{
  width 100%
}
</style>