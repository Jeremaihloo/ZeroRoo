<style lang="less" rel="stylesheet/less">

</style>
<template>
  <div class="application-section">
    <app-window :key="index" v-for="(app, index) in apps" :app="app"></app-window>
  </div>
</template>

<script>
export default {
  props: {
    apps: Array
  },
  data: function () {
    return {
    }
  },
  methods: {
  },
  components: {
    appWindow: require('../components/app-window.vue')
  },
  ready: function () {
  }
}
</script>