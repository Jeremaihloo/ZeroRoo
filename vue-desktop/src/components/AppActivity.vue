
<template>
  <div class="activity" ref="main">
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
    item: function (newVal, oldVal) {
      // console.log(newVal, oldVal)
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
    console.log('AppActivity Mounted', this.item)
    if (this.item) {
      this.url = this.item.Target
      this.go()
    }
    // var sd = new StartDrag(this.$refs.header, this.$refs.main)
    // StartDrag(this.$refs.header, this.$refs.main)
    // console.log(sd)
  },
  ready () {
    console.log('AppActivity Ready', this.item)
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