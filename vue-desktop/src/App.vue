<template>
  <div id="app">
    <div class="root">
      <files-container class="scope"></files-container>
      <applications-container class="scope"></applications-container>
    </div>
  </div>
</template>

<script>
import FilesContainer from './components/FilesContainer'
import ApplicationsContainer from './components/ApplicationsContainer'

export default {
  name: 'app',
  components: {
    FilesContainer,
    ApplicationsContainer
  }
}
</script>

<style lang="less" rel="stylesheet/less">

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
}
</style>
