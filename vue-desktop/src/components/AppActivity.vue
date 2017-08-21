
<template>
  <div class="activity">
    <header>
      <span class="icon"></span>
      <span class="btn-min"></span>
      <span class="btn-max"></span>
      <span class="btn-close"></span>
    </header>
    <section class="activity-body">
      <iframe ref="iframe" :src="src" name="test" height="100%" width="100%" frameborder="0"></iframe>
    </section>
  </div>
</template>

<script>

export default {
  props: ['activity'],
  data: function () {
    return {
      url: '',
      src: ''
    }
  },
  watch: {
    activity: function (newVal, oldVal) {
      console.log(newVal, oldVal)
    }
  },
  methods: {
    go: function () {
      // if (!$.trim(this.url)) return
      this.iframeGo(this.url)
    },
    iframeGo: function (url) {
      this.src = url
    }
  },
  components: {},
  mounted() {
    console.log('AppActivity Mounted')
    console.log('AppActivity:ready', this.activity)
    if (this.activity) {
      this.url = this.activity.HtmlUri
      this.go()
    }
  },
  ready() {
    console.log('AppActivity:ready', this.activity)
    if (this.activity) {
      this.url = this.activity.HtmlUri
      this.go()
    }
  }
}
</script>

<style lang="less" rel="stylesheet/less">

</style>