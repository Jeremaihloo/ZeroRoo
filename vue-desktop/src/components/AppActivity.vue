
<template>
  <div class="activity" ref="main">
    <header ref="header">
      <span class="icon"></span>
      <span class="title">{{activity.text}}</span>
      <span class="btn-min"></span>
      <span class="btn-max"></span>
      <span class="btn-close"></span>
    </header>
    <div class="activity-body">
      <iframe ref="iframe" :src="src" name="test" height="100%" width="100%" frameborder="0"></iframe>
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
  mounted () {
    console.log('AppActivity Mounted')
    console.log('AppActivity:ready', this.item)
    if (this.activity) {
      this.url = this.item.Target
      this.go()
    }
    // var sd = new StartDrag(this.$refs.header, this.$refs.main)
    // StartDrag(this.$refs.header, this.$refs.main)
    // console.log(sd)
  },
  ready () {
    console.log('AppActivity:ready', this.item)
    if (this.activity) {
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